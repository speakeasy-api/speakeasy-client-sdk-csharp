<!-- Start SDK Example Usage [usage] -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using System.Collections.Generic;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

RemoteSource req = new RemoteSource() {
    Inputs = new List<RemoteDocument>() {
        new RemoteDocument() {
            RegistryUrl = "https://productive-swine.net",
        },
    },
    Output = new RemoteDocument() {
        RegistryUrl = "https://spiteful-apricot.info",
    },
};

var res = await sdk.Artifacts.CreateRemoteSourceAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->