# Artifacts
(*Artifacts*)

### Available Operations

* [GetNamespaces](#getnamespaces) - Each namespace contains many revisions.
* [GetRevisions](#getrevisions)
* [Preflight](#preflight) - Get access token for communicating with OCI distribution endpoints

## GetNamespaces

Each namespace contains many revisions.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    },
    workspaceID: "<value>");

var res = await sdk.Artifacts.GetNamespacesAsync();

// handle response
```


### Response

**[Models.Operations.GetNamespacesResponse](../../Models/Operations/GetNamespacesResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## GetRevisions

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

GetRevisionsRequest req = new GetRevisionsRequest() {
    NamespaceId = "<value>",
};

var res = await sdk.Artifacts.GetRevisionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [GetRevisionsRequest](../../Models/Operations/GetRevisionsRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |


### Response

**[Models.Operations.GetRevisionsResponse](../../Models/Operations/GetRevisionsResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## Preflight

Get access token for communicating with OCI distribution endpoints

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    },
    workspaceID: "<value>");

var res = await sdk.Artifacts.PreflightAsync();

// handle response
```


### Response

**[PreflightResponse](../../Models/Operations/PreflightResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |
