<!-- Start SDK Example Usage [usage] -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;
using System.Collections.Generic;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    },
    workspaceID: "string");

GetApisRequest req = new GetApisRequest() {
    Metadata = new Dictionary<string, List<string>>() {
        { "key", new List<string>() {
            "string",
        } },
    },
    Op = new QueryParamOp() {
        And = false,
    },
};

var res = await sdk.Apis.GetApisAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->