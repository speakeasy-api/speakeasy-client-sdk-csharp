<!-- Start SDK Example Usage -->


```csharp
using Speakeasy;
using Speakeasy.Models.Shared;
using Speakeasy.Models.Operations;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Apis.GetApisAsync(new GetApisRequest() {
    Metadata = new Dictionary<string, List<string>>() {
        { "aut", new List<string>() {
            "bypassing",
        } },
    },
    Op = new GetApisOp() {
        And = false,
    },
});

// handle response
```
<!-- End SDK Example Usage -->