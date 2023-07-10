<!-- Start SDK Example Usage -->
```csharp
using SDK;
using SDK.Models.Security;
using SDK.Models.Apis;

var sdk = new SDKSDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Apis.GetApis(request);
```
<!-- End SDK Example Usage -->