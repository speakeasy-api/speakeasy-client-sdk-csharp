# Events

## Overview

REST APIs for managing events captured by a speakeasy binary (CLI, GitHub Action etc)

### Available Operations

* [GetEventsByTarget](#geteventsbytarget) - Load recent events for a particular workspace
* [GetTargets](#gettargets) - Load targets for a particular workspace
* [GetTargetsDeprecated](#gettargetsdeprecated) - Load targets for a particular workspace
* [Post](#post) - Post events for a specific workspace
* [Search](#search) - Search events for a particular workspace by any field

## GetEventsByTarget

Load recent events for a particular workspace

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getWorkspaceEventsByTarget" method="get" path="/v1/workspace/{workspace_id}/events/targets/{target_id}/events" -->
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

GetWorkspaceEventsByTargetRequest req = new GetWorkspaceEventsByTargetRequest() {
    TargetId = "<id>",
};

var res = await sdk.Events.GetEventsByTargetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [GetWorkspaceEventsByTargetRequest](../../Models/Operations/GetWorkspaceEventsByTargetRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[GetWorkspaceEventsByTargetResponse](../../Models/Operations/GetWorkspaceEventsByTargetResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 5XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 4XX                                     | \*/\*                                   |

## GetTargets

Load targets for a particular workspace

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getWorkspaceTargets" method="get" path="/v1/workspace/events/targets" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetWorkspaceTargetsRequest? req = null;

var res = await sdk.Events.GetTargetsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetWorkspaceTargetsRequest](../../Models/Operations/GetWorkspaceTargetsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[GetWorkspaceTargetsResponse](../../Models/Operations/GetWorkspaceTargetsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 5XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 4XX                                     | \*/\*                                   |

## GetTargetsDeprecated

Load targets for a particular workspace

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getWorkspaceTargetsDeprecated" method="get" path="/v1/workspace/{workspace_id}/events/targets" -->
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

GetWorkspaceTargetsDeprecatedRequest req = new GetWorkspaceTargetsDeprecatedRequest() {};

var res = await sdk.Events.GetTargetsDeprecatedAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [GetWorkspaceTargetsDeprecatedRequest](../../Models/Operations/GetWorkspaceTargetsDeprecatedRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[GetWorkspaceTargetsDeprecatedResponse](../../Models/Operations/GetWorkspaceTargetsDeprecatedResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 5XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 4XX                                     | \*/\*                                   |

## Post

Sends an array of events to be stored for a particular workspace.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="postWorkspaceEvents" method="post" path="/v1/workspace/{workspace_id}/events" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;
using System;
using System.Collections.Generic;

var sdk = new SDK(
    workspaceId: "<id>",
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    }
);

PostWorkspaceEventsRequest req = new PostWorkspaceEventsRequest() {
    RequestBody = new List<CliEvent>() {
        new CliEvent() {
            CreatedAt = System.DateTime.Parse("2024-02-16T09:12:42.397Z"),
            ExecutionId = "<id>",
            Id = "<id>",
            InteractionType = InteractionType.Quickstart,
            LocalStartedAt = System.DateTime.Parse("2025-01-23T01:13:51.002Z"),
            SpeakeasyApiKeyName = "<value>",
            SpeakeasyVersion = "<value>",
            Success = true,
            WorkspaceId = "<id>",
        },
    },
};

var res = await sdk.Events.PostAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PostWorkspaceEventsRequest](../../Models/Operations/PostWorkspaceEventsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[PostWorkspaceEventsResponse](../../Models/Operations/PostWorkspaceEventsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 5XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 4XX                                     | \*/\*                                   |

## Search

Search events for a particular workspace by any field

### Example Usage

<!-- UsageSnippet language="csharp" operationID="searchWorkspaceEvents" method="get" path="/v1/workspace/{workspace_id}/events" -->
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

SearchWorkspaceEventsRequest req = new SearchWorkspaceEventsRequest() {};

var res = await sdk.Events.SearchAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [SearchWorkspaceEventsRequest](../../Models/Operations/SearchWorkspaceEventsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[SearchWorkspaceEventsResponse](../../Models/Operations/SearchWorkspaceEventsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 5XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 4XX                                     | \*/\*                                   |