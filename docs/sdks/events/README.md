# Events
(*Events*)

## Overview

REST APIs for capturing event data

### Available Operations

* [PostWorkspaceEvents](#postworkspaceevents) - Post events for a specific workspace

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
    workspaceID: "string");

PostWorkspaceEventsRequest req = new PostWorkspaceEventsRequest() {
    RequestBody = new List<CliEvent>() {
        new CliEvent() {
            CreatedAt = System.DateTime.Parse("2024-11-21T06:58:42.120Z"),
            ExecutionId = "string",
            Id = "<ID>",
            InteractionType = InteractionType.CliExec,
            LocalStartedAt = System.DateTime.Parse("2024-05-07T12:35:47.182Z"),
            SpeakeasyApiKeyName = "string",
            SpeakeasyVersion = "string",
            Success = false,
            WorkspaceId = "string",
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

