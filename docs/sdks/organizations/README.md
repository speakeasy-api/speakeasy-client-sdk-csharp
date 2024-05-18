# Organizations
(*Organizations*)

### Available Operations

* [GetOrganizationUsage](#getorganizationusage) - Get billing usage summary for a particular organization
* [GetOrganizations](#getorganizations) - Get organizations for a user

## GetOrganizationUsage

Returns a billing usage summary by target languages for a particular organization

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new Speakeasy(security: new Security() {
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

var sdk = new Speakeasy(security: new Security() {
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
