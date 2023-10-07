# PluginsSDK
(*Plugins*)

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
                Key = "<key>",
                Operator = "West parse Pickup",
                Value = "purple Pants",
            },
        },
        Limit = 996936,
        Offset = 273299,
        Operator = "Bedfordshire meaningfully",
    },
    PluginID = "Botswana Metal",
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
    Code = "drafty",
    PluginId = "Rock North exuding",
    Title = "navigating schemas",
    WorkspaceId = "Plastic siemens navigate",
});

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | [Plugin](../../models/shared/Plugin.md)    | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[UpsertPluginResponse](../../models/operations/UpsertPluginResponse.md)**

