# Subscriptions
(*Subscriptions*)

## Overview

REST APIs for managing subscriptions

### Available Operations

* [ActivateSubscriptionNamespace](#activatesubscriptionnamespace) - Activate an ignored namespace for a subscription
* [IgnoreSubscriptionNamespace](#ignoresubscriptionnamespace) - Ignored a namespace for a subscription

## ActivateSubscriptionNamespace

Activate an ignored namespace for a subscription

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

ActivateSubscriptionNamespaceRequest req = new ActivateSubscriptionNamespaceRequest() {
    NamespaceName = "<value>",
    SubscriptionID = "<id>",
};

var res = await sdk.Subscriptions.ActivateSubscriptionNamespaceAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [ActivateSubscriptionNamespaceRequest](../../Models/Operations/ActivateSubscriptionNamespaceRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[ActivateSubscriptionNamespaceResponse](../../Models/Operations/ActivateSubscriptionNamespaceResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## IgnoreSubscriptionNamespace

Ignored a namespace for a subscription

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

IgnoreSubscriptionNamespaceRequest req = new IgnoreSubscriptionNamespaceRequest() {
    NamespaceName = "<value>",
    SubscriptionID = "<id>",
};

var res = await sdk.Subscriptions.IgnoreSubscriptionNamespaceAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [IgnoreSubscriptionNamespaceRequest](../../Models/Operations/IgnoreSubscriptionNamespaceRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[IgnoreSubscriptionNamespaceResponse](../../Models/Operations/IgnoreSubscriptionNamespaceResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |