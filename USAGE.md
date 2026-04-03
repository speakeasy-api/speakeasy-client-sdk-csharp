<!-- Start SDK Example Usage [usage] -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

RemoteSource? req = null;

var res = await sdk.Artifacts.CreateRemoteSourceAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->