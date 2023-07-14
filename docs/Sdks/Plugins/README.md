# plugins

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
using Speakeasy.Models.Security;
using Speakeasy.Models.Plugins;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Plugins.GetPluginsAsync();
```


### Response

**[GetPluginsResponse](../../Models/Plugins/GetPluginsResponse.md)**


## RunPlugin

Run a plugin

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Plugins;
using Speakeasy.Models.Shared;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Plugins.RunPluginAsync(new RunPluginRequest() {
    Filters = new Filters() {
        Filters = new List<Filter>() {
            new Filter() {
                Key = "repellat",
                Operator = "mollitia",
                Value = "occaecati",
            },
        },
        Limit = 253291,
        Offset = 414369,
        Operator = "quam",
    },
    PluginID = "molestiae",
});
```

### Parameters

| Parameter                                                    | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `request`                                                    | [RunPluginRequest](../../Models/Plugins/RunPluginRequest.md) | :heavy_check_mark:                                           | The request object to use for the request.                   |


### Response

**[RunPluginResponse](../../Models/Plugins/RunPluginResponse.md)**


## UpsertPlugin

Upsert a plugin

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Plugins;
using Speakeasy.Models.Shared;
using System;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Plugins.UpsertPluginAsync(new Plugin() {
    Code = "velit",
    CreatedAt = DateTime.Parse("2022-09-06T22:51:09.401Z"),
    EvalHash = "quis",
    PluginId = "vitae",
    Title = "Miss",
    UpdatedAt = DateTime.Parse("2022-05-14T10:37:30.872Z"),
    WorkspaceId = "odit",
});
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | [Plugin](../../Models/Shared/Plugin.md)    | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[UpsertPluginResponse](../../Models/Plugins/UpsertPluginResponse.md)**

