# Speakeasy SDK


## Overview

Speakeasy API: The Speakeasy API allows teams to manage common operations with their APIs

The Speakeasy Platform Documentation
<https://speakeasyapi.dev/docs/>
### Available Operations

* [ValidateApiKey](#validateapikey) - Validate the current api key.

## ValidateApiKey

Validate the current api key.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Shared;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Speakeasy.ValidateApiKeyAsync();

// handle response
```


### Response

**[ValidateApiKeyResponse](../../models/operations/ValidateApiKeyResponse.md)**

