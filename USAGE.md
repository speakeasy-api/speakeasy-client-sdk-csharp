<!-- Start SDK Example Usage -->
```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Apis;

var sdk = new SpeakeasySDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Apis.GetApis(request);
```
<!-- End SDK Example Usage -->