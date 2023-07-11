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
using Speakeasy.Models.Security;

var sdk = new SpeakeasySDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Speakeasy.ValidateApiKey();
```


### Response

**[ValidateApiKeyResponse](../../Models/Speakeasy/ValidateApiKeyResponse.md)**

