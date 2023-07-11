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
using SDK;
using SDK.Models.Security;
using SDK.Models.Plugins;

var sdk = new SDKSDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Plugins.GetPlugins();
```


### Response

**[GetPluginsResponse](../../Models/Plugins/GetPluginsResponse.md)**


## RunPlugin

Run a plugin

### Example Usage

```csharp
using SDK;
using SDK.Models.Security;
using SDK.Models.Plugins;

var sdk = new SDKSDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Plugins.RunPlugin(request);
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
using SDK;
using SDK.Models.Security;
using SDK.Models.Plugins;

var sdk = new SDKSDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Plugins.UpsertPlugin(request);
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | [Plugin](../../Models/Shared/Plugin.md)    | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[UpsertPluginResponse](../../Models/Plugins/UpsertPluginResponse.md)**

