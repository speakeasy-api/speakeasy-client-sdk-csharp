# Events
(*Events*)

## Overview

REST APIs for capturing event data

### Available Operations

* [GetWorkspaceEvents](#getworkspaceevents) - Load recent events for a particular workspace
* [GetWorkspaceTargets](#getworkspacetargets) - Load targets for a particular workspace
* [PostWorkspaceEvents](#postworkspaceevents) - Post events for a specific workspace

## GetWorkspaceEvents

Load recent events for a particular workspace

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

GetWorkspaceEventsRequest req = new GetWorkspaceEventsRequest() {};

var res = await sdk.Events.GetWorkspaceEventsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetWorkspaceEventsRequest](../../Models/Operations/GetWorkspaceEventsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[GetWorkspaceEventsResponse](../../Models/Operations/GetWorkspaceEventsResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 5XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## GetWorkspaceTargets

Load targets for a particular workspace

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

GetWorkspaceTargetsRequest req = new GetWorkspaceTargetsRequest() {};

var res = await sdk.Events.GetWorkspaceTargetsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetWorkspaceTargetsRequest](../../Models/Operations/GetWorkspaceTargetsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[GetWorkspaceTargetsResponse](../../Models/Operations/GetWorkspaceTargetsResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 5XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## PostWorkspaceEvents

Sends an array of events to be stored for a particular workspace.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;
using System.Collections.Generic;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    },
    workspaceID: "<value>");

PostWorkspaceEventsRequest req = new PostWorkspaceEventsRequest() {
    RequestBody = new List<CliEvent>() {
        new CliEvent() {
            CreatedAt = System.DateTime.Parse("2024-11-21T06:58:42.120Z"),
            ExecutionId = "<value>",
            Id = "<id>",
            InteractionType = InteractionType.CliExec,
            LocalStartedAt = System.DateTime.Parse("2024-05-07T12:35:47.182Z"),
            SpeakeasyApiKeyName = "<value>",
            SpeakeasyVersion = "<value>",
            Success = false,
            WorkspaceId = "<value>",
        },
    },
};

var res = await sdk.Events.PostWorkspaceEventsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PostWorkspaceEventsRequest](../../Models/Operations/PostWorkspaceEventsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[PostWorkspaceEventsResponse](../../Models/Operations/PostWorkspaceEventsResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 5XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |
