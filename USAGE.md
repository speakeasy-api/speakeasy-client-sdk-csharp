<!-- Start SDK Example Usage [usage] -->
```csharp
using Speakeasy.Client.SDK;
using Speakeasy.Client.SDK.Models.Shared;
using Speakeasy.Client.SDK.Models.Operations;
using System.Collections.Generic;

var sdk = new SpeakeasySDK(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

GetApisRequest req = new GetApisRequest() {};

var res = await sdk.Apis.GetApisAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->