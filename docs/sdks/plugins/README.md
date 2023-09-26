# Plugins

## Overview

REST APIs for managing and running plugins

### Available Operations

* [GetPlugins](#getplugins) - Get all plugins for the current workspace.
* [RunPlugin](#runplugin) - Run a plugin
* [UpsertPlugin](#upsertplugin) - Upsert a plugin

## GetPlugins

Get all plugins for the current workspace.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Shared;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Plugins.GetPluginsAsync();

// handle response
```


### Response

**[GetPluginsResponse](../../models/operations/GetPluginsResponse.md)**


## RunPlugin

Run a plugin

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

var res = await sdk.Plugins.RunPluginAsync(new RunPluginRequest() {
    Filters = new Filters() {
        Filters = new List<Filter>() {
            new Filter() {
                Key = "aspernatur",
                Operator = "perferendis",
                Value = "ad",
            },
        },
        Limit = 617636,
        Offset = 149675,
        Operator = "iste",
    },
    PluginID = "dolor",
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [RunPluginRequest](../../models/operations/RunPluginRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[RunPluginResponse](../../models/operations/RunPluginResponse.md)**


## UpsertPlugin

Upsert a plugin

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Shared;
using System;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Plugins.UpsertPluginAsync(new Plugin() {
    Code = "natus",
    CreatedAt = DateTime.Parse("2022-01-21T12:46:00.641Z"),
    EvalHash = "saepe",
    PluginId = "fuga",
    Title = "Ms.",
    UpdatedAt = DateTime.Parse("2022-05-22T05:33:50.280Z"),
    WorkspaceId = "iure",
});

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | [Plugin](../../models/shared/Plugin.md)    | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[UpsertPluginResponse](../../models/operations/UpsertPluginResponse.md)**

