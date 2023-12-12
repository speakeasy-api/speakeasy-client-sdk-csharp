# Plugins
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
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Plugins.GetPluginsAsync();

// handle response
```


### Response

**[GetPluginsResponse](../../Models/Operations/GetPluginsResponse.md)**


## RunPlugin

Run a plugin

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;
using System.Collections.Generic;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

RunPluginRequest req = new RunPluginRequest() {
    Filters = new Filters() {
        Filters = new List<Filter>() {
            new Filter() {
                Key = "<key>",
                Operator = "string",
                Value = "string",
            },
        },
        Limit = 669298,
        Offset = 94585,
        Operator = "string",
    },
    PluginID = "string",
};

var res = await sdk.Plugins.RunPluginAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [RunPluginRequest](../../Models/Operations/RunPluginRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[RunPluginResponse](../../Models/Operations/RunPluginResponse.md)**


## UpsertPlugin

Upsert a plugin

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

Plugin req = new Plugin() {
    Code = "string",
    PluginId = "string",
    Title = "string",
    WorkspaceId = "string",
};

var res = await sdk.Plugins.UpsertPluginAsync(req);

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | [Plugin](../../Models/Shared/Plugin.md)    | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[UpsertPluginResponse](../../Models/Operations/UpsertPluginResponse.md)**

