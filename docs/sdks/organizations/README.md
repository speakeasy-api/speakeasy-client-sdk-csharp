# Organizations
(*Organizations*)

### Available Operations

* [CreateFreeTrial](#createfreetrial) - Create a free trial for an organization
* [GetOrganizationUsage](#getorganizationusage) - Get billing usage summary for a particular organization
* [GetOrganizations](#getorganizations) - Get organizations for a user

## CreateFreeTrial

Creates a free trial for an organization

### Example Usage

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

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## GetOrganizationUsage

Returns a billing usage summary by target languages for a particular organization

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Organizations.GetOrganizationUsageAsync();

// handle response
```


### Response

**[GetOrganizationUsageResponse](../../Models/Operations/GetOrganizationUsageResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## GetOrganizations

Returns a list of organizations a user has access too

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Organizations.GetOrganizationsAsync();

// handle response
```


### Response

**[GetOrganizationsResponse](../../Models/Operations/GetOrganizationsResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |
