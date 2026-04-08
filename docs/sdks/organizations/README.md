# Organizations

## Overview

REST APIs for managing Organizations (speakeasy L1 Tenancy construct)

### Available Operations

* [Create](#create) - Create an organization
* [CreateBillingAddOns](#createbillingaddons) - Create billing add ons
* [CreateFreeTrial](#createfreetrial) - Create a free trial for an organization
* [DeleteBillingAddOn](#deletebillingaddon) - Delete billing add ons
* [Get](#get) - Get organization
* [GetAll](#getall) - Get organizations for a user
* [GetBillingAddOns](#getbillingaddons) - Get billing add ons
* [GetUsage](#getusage) - Get billing usage summary for a particular organization

## Create

Creates an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createOrganization" method="post" path="/v1/organization" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using System;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

Organization req = new Organization() {
    AccountType = AccountType.ScaleUp,
    CreatedAt = System.DateTime.Parse("2026-10-26T09:05:00.560Z"),
    Id = "<id>",
    Name = "<value>",
    Slug = "<value>",
    SsoActivated = false,
    TelemetryDisabled = false,
    UpdatedAt = System.DateTime.Parse("2024-12-22T08:00:51.380Z"),
};

var res = await sdk.Organizations.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                           | Type                                                | Required                                            | Description                                         |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `request`                                           | [Organization](../../Models/Shared/Organization.md) | :heavy_check_mark:                                  | The request object to use for the request.          |

### Response

**[CreateOrganizationResponse](../../Models/Operations/CreateOrganizationResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## CreateBillingAddOns

Create billing add ons

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createBillingAddOns" method="post" path="/v1/organization/add_ons" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using System.Collections.Generic;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

OrganizationBillingAddOnRequest req = new OrganizationBillingAddOnRequest() {
    AddOns = new List<BillingAddOn>() {
        BillingAddOn.CustomCodeRegions,
    },
};

var res = await sdk.Organizations.CreateBillingAddOnsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [OrganizationBillingAddOnRequest](../../Models/Shared/OrganizationBillingAddOnRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[CreateBillingAddOnsResponse](../../Models/Operations/CreateBillingAddOnsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 5XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 4XX                                     | \*/\*                                   |

## CreateFreeTrial

Creates a free trial for an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createFreeTrial" method="post" path="/v1/organization/free_trial" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Organizations.CreateFreeTrialAsync();

// handle response
```

### Response

**[CreateFreeTrialResponse](../../Models/Operations/CreateFreeTrialResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## DeleteBillingAddOn

Delete billing add ons

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteBillingAddOn" method="delete" path="/v1/organization/add_ons/{add_on}" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

DeleteBillingAddOnRequest req = new DeleteBillingAddOnRequest() {
    AddOn = BillingAddOn.SDKTesting,
};

var res = await sdk.Organizations.DeleteBillingAddOnAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [DeleteBillingAddOnRequest](../../Models/Operations/DeleteBillingAddOnRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[DeleteBillingAddOnResponse](../../Models/Operations/DeleteBillingAddOnResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 5XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 4XX                                     | \*/\*                                   |

## Get

Get information about a particular organization.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getOrganization" method="get" path="/v1/organization/{organizationID}" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetOrganizationRequest req = new GetOrganizationRequest() {
    OrganizationID = "<id>",
};

var res = await sdk.Organizations.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [GetOrganizationRequest](../../Models/Operations/GetOrganizationRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[GetOrganizationResponse](../../Models/Operations/GetOrganizationResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## GetAll

Returns a list of organizations a user has access too

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getOrganizations" method="get" path="/v1/organizations" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Organizations.GetAllAsync();

// handle response
```

### Response

**[GetOrganizationsResponse](../../Models/Operations/GetOrganizationsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## GetBillingAddOns

Get billing add ons

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getBillingAddOns" method="get" path="/v1/organization/add_ons" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Organizations.GetBillingAddOnsAsync();

// handle response
```

### Response

**[GetBillingAddOnsResponse](../../Models/Operations/GetBillingAddOnsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 5XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 4XX                                     | \*/\*                                   |

## GetUsage

Returns a billing usage summary by target languages for a particular organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getOrganizationUsage" method="get" path="/v1/organization/usage" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Organizations.GetUsageAsync();

// handle response
```

### Response

**[GetOrganizationUsageResponse](../../Models/Operations/GetOrganizationUsageResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |