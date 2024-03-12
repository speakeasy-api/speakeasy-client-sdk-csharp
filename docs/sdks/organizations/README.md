# Organizations
(*Organizations*)

### Available Operations

* [GetOrganizations](#getorganizations) - Get organizations for a user

## GetOrganizations

Returns a list of organizations a user has access too

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    },
    workspaceID: "<value>");

var res = await sdk.Organizations.GetOrganizationsAsync();

// handle response
```


### Response

**[GetOrganizationsResponse](../../Models/Operations/GetOrganizationsResponse.md)**

