# Speakeasy SDK


## Overview

Speakeasy API: The Speakeasy API allows teams to manage common operations with their APIs

The Speakeasy Platform Documentation
</docs>
### Available Operations

* [ValidateApiKey](#validateapikey) - Validate the current api key.

## ValidateApiKey

Validate the current api key.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.ValidateApiKeyAsync();

// handle response
```


### Response

**[ValidateApiKeyResponse](../../Models/Operations/ValidateApiKeyResponse.md)**

