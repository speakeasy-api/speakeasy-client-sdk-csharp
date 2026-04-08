# Workspaces

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

<!-- UsageSnippet language="csharp" operationID="createWorkspace" method="post" path="/v1/workspace" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using System;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

Workspace req = new Workspace() {
    CreatedAt = System.DateTime.Parse("2024-11-17T13:41:10.525Z"),
    Id = "<id>",
    Name = "<value>",
    OrganizationId = "<id>",
    Slug = "<value>",
    UpdatedAt = System.DateTime.Parse("2025-11-21T08:36:32.740Z"),
    Verified = true,
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

<!-- UsageSnippet language="csharp" operationID="createWorkspaceToken" method="post" path="/v1/workspace/{workspace_id}/tokens" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;
using System;

var sdk = new SDK(
    workspaceId: "<id>",
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    }
);

CreateWorkspaceTokenRequest req = new CreateWorkspaceTokenRequest() {
    WorkspaceToken = new WorkspaceToken() {
        Alg = "<value>",
        CreatedAt = System.DateTime.Parse("2025-10-04T10:23:04.522Z"),
        Id = "<id>",
        Key = "<key>",
        Name = "<value>",
        WorkspaceId = "<id>",
    },
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

<!-- UsageSnippet language="csharp" operationID="deleteWorkspaceToken" method="delete" path="/v1/workspace/{workspace_id}/tokens/{tokenID}" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(
    workspaceId: "<id>",
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    }
);

DeleteWorkspaceTokenRequest req = new DeleteWorkspaceTokenRequest() {
    TokenID = "<id>",
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

<!-- UsageSnippet language="csharp" operationID="getWorkspaceByContext" method="get" path="/v1/workspace" -->
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

<!-- UsageSnippet language="csharp" operationID="getWorkspaces" method="get" path="/v1/workspaces" -->
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

<!-- UsageSnippet language="csharp" operationID="getWorkspace" method="get" path="/v1/workspace/{workspace_id}" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(
    workspaceId: "<id>",
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    }
);

GetWorkspaceRequest req = new GetWorkspaceRequest() {};

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

<!-- UsageSnippet language="csharp" operationID="getWorkspaceFeatureFlags" method="get" path="/v1/workspace/{workspace_id}/feature_flags" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(
    workspaceId: "<id>",
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    }
);

GetWorkspaceFeatureFlagsRequest req = new GetWorkspaceFeatureFlagsRequest() {};

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

<!-- UsageSnippet language="csharp" operationID="getWorkspaceSettings" method="get" path="/v1/workspace/{workspace_id}/settings" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(
    workspaceId: "<id>",
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    }
);

GetWorkspaceSettingsRequest req = new GetWorkspaceSettingsRequest() {};

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

<!-- UsageSnippet language="csharp" operationID="getWorkspaceTeam" method="get" path="/v1/workspace/{workspace_id}/team" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(
    workspaceId: "<id>",
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    }
);

GetWorkspaceTeamRequest req = new GetWorkspaceTeamRequest() {};

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

<!-- UsageSnippet language="csharp" operationID="getWorkspaceTokens" method="get" path="/v1/workspace/{workspace_id}/tokens" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(
    workspaceId: "<id>",
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    }
);

GetWorkspaceTokensRequest req = new GetWorkspaceTokensRequest() {};

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

<!-- UsageSnippet language="csharp" operationID="grantUserAccessToWorkspace" method="put" path="/v1/workspace/{workspace_id}/team/email/{email}" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(
    workspaceId: "<id>",
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    }
);

GrantUserAccessToWorkspaceRequest req = new GrantUserAccessToWorkspaceRequest() {
    Email = "Idella24@gmail.com",
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

<!-- UsageSnippet language="csharp" operationID="revokeUserAccessToWorkspace" method="delete" path="/v1/workspace/{workspace_id}/team/{userId}" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(
    workspaceId: "<id>",
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    }
);

RevokeUserAccessToWorkspaceRequest req = new RevokeUserAccessToWorkspaceRequest() {
    UserId = "<id>",
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

<!-- UsageSnippet language="csharp" operationID="setWorkspaceFeatureFlags" method="post" path="/v1/workspace/feature_flags" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using System.Collections.Generic;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

WorkspaceFeatureFlagRequest req = new WorkspaceFeatureFlagRequest() {
    FeatureFlags = new List<WorkspaceFeatureFlag>() {},
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

<!-- UsageSnippet language="csharp" operationID="updateWorkspaceDetails" method="post" path="/v1/workspace/{workspace_id}/details" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;
using System;

var sdk = new SDK(
    workspaceId: "<id>",
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    }
);

UpdateWorkspaceDetailsRequest req = new UpdateWorkspaceDetailsRequest() {
    Workspace = new Workspace() {
        CreatedAt = System.DateTime.Parse("2024-08-01T22:30:24.264Z"),
        Id = "<id>",
        Name = "<value>",
        OrganizationId = "<id>",
        Slug = "<value>",
        UpdatedAt = System.DateTime.Parse("2026-01-24T03:53:13.581Z"),
        Verified = true,
    },
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

<!-- UsageSnippet language="csharp" operationID="updateWorkspaceSettings" method="put" path="/v1/workspace/{workspace_id}/settings" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;
using System;

var sdk = new SDK(
    workspaceId: "<id>",
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    }
);

UpdateWorkspaceSettingsRequest req = new UpdateWorkspaceSettingsRequest() {
    WorkspaceSettings = new WorkspaceSettings() {
        CreatedAt = System.DateTime.Parse("2026-03-09T15:48:09.330Z"),
        UpdatedAt = System.DateTime.Parse("2026-11-24T16:37:53.492Z"),
        WebhookUrl = "https://wobbly-lid.org",
        WorkspaceId = "<id>",
    },
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