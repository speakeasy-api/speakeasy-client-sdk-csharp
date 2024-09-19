<!-- Start SDK Example Usage [usage] -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using System.Collections.Generic;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetApisRequest req = new GetApisRequest() {};

var res = await sdk.Apis.GetApisAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->