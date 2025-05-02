# SchemaStore
(*SchemaStore*)

## Overview

### Available Operations

* [CreateSchemaStoreItem](#createschemastoreitem) - Create a schema in the schema store
* [GetSchemaStoreItem](#getschemastoreitem) - Get a OAS schema from the schema store

## CreateSchemaStoreItem

Create a schema in the schema store

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

CreateSchemaStoreItemRequestBody req = new CreateSchemaStoreItemRequestBody() {
    Format = Format.Yaml,
    PackageName = "<value>",
    SDKClassname = "<value>",
    Spec = "<value>",
};

var res = await sdk.SchemaStore.CreateSchemaStoreItemAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [CreateSchemaStoreItemRequestBody](../../Models/Operations/CreateSchemaStoreItemRequestBody.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[CreateSchemaStoreItemResponse](../../Models/Operations/CreateSchemaStoreItemResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## GetSchemaStoreItem

Get a OAS schema from the schema store

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetSchemaStoreItemRequestBody req = new GetSchemaStoreItemRequestBody() {};

var res = await sdk.SchemaStore.GetSchemaStoreItemAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [GetSchemaStoreItemRequestBody](../../Models/Operations/GetSchemaStoreItemRequestBody.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[GetSchemaStoreItemResponse](../../Models/Operations/GetSchemaStoreItemResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |