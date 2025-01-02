# Github
(*Github*)

## Overview

REST APIs for managing the github integration

### Available Operations

* [CheckAccess](#checkaccess)
* [CheckPublishingPRs](#checkpublishingprs)
* [CheckPublishingSecrets](#checkpublishingsecrets)
* [ConfigureCodeSamples](#configurecodesamples)
* [ConfigureMintlifyRepo](#configuremintlifyrepo)
* [ConfigureTarget](#configuretarget)
* [GetAction](#getaction)
* [GetSetup](#getsetup)
* [LinkGithub](#linkgithub)
* [StorePublishingSecrets](#storepublishingsecrets)
* [TriggerAction](#triggeraction)

## CheckAccess

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

CheckGithubAccessRequest req = new CheckGithubAccessRequest() {
    Org = "<value>",
    Repo = "<value>",
};

var res = await sdk.Github.CheckAccessAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [CheckGithubAccessRequest](../../Models/Operations/CheckGithubAccessRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[CheckGithubAccessResponse](../../Models/Operations/CheckGithubAccessResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## CheckPublishingPRs

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GithubCheckPublishingPRsRequest req = new GithubCheckPublishingPRsRequest() {
    GenerateGenLockId = "<id>",
    Org = "<value>",
    Repo = "<value>",
};

var res = await sdk.Github.CheckPublishingPRsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GithubCheckPublishingPRsRequest](../../Models/Operations/GithubCheckPublishingPRsRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[GithubCheckPublishingPRsResponse](../../Models/Operations/GithubCheckPublishingPRsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## CheckPublishingSecrets

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GithubCheckPublishingSecretsRequest req = new GithubCheckPublishingSecretsRequest() {
    GenerateGenLockId = "<id>",
};

var res = await sdk.Github.CheckPublishingSecretsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [GithubCheckPublishingSecretsRequest](../../Models/Operations/GithubCheckPublishingSecretsRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[GithubCheckPublishingSecretsResponse](../../Models/Operations/GithubCheckPublishingSecretsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## ConfigureCodeSamples

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GithubConfigureCodeSamplesRequest req = new GithubConfigureCodeSamplesRequest() {
    Org = "<value>",
    Repo = "<value>",
    TargetName = "<value>",
};

var res = await sdk.Github.ConfigureCodeSamplesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GithubConfigureCodeSamplesRequest](../../Models/Shared/GithubConfigureCodeSamplesRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[Models.Operations.GithubConfigureCodeSamplesResponse](../../Models/Operations/GithubConfigureCodeSamplesResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## ConfigureMintlifyRepo

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using System.Collections.Generic;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GithubConfigureMintlifyRepoRequest req = new GithubConfigureMintlifyRepoRequest() {
    Input = "<value>",
    Org = "<value>",
    Overlays = new List<string>() {
        "<value>",
    },
    Repo = "<value>",
};

var res = await sdk.Github.ConfigureMintlifyRepoAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [GithubConfigureMintlifyRepoRequest](../../Models/Shared/GithubConfigureMintlifyRepoRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[GithubConfigureMintlifyRepoResponse](../../Models/Operations/GithubConfigureMintlifyRepoResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## ConfigureTarget

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GithubConfigureTargetRequest req = new GithubConfigureTargetRequest() {
    Org = "<value>",
    RepoName = "<value>",
};

var res = await sdk.Github.ConfigureTargetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GithubConfigureTargetRequest](../../Models/Shared/GithubConfigureTargetRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[GithubConfigureTargetResponse](../../Models/Operations/GithubConfigureTargetResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## GetAction

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetGitHubActionRequest req = new GetGitHubActionRequest() {
    Org = "<value>",
    Repo = "<value>",
};

var res = await sdk.Github.GetActionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [GetGitHubActionRequest](../../Models/Operations/GetGitHubActionRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[GetGitHubActionResponse](../../Models/Operations/GetGitHubActionResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## GetSetup

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetGithubSetupStateRequest req = new GetGithubSetupStateRequest() {
    GenerateGenLockId = "<id>",
    Org = "<value>",
    Repo = "<value>",
};

var res = await sdk.Github.GetSetupAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetGithubSetupStateRequest](../../Models/Operations/GetGithubSetupStateRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[GetGithubSetupStateResponse](../../Models/Operations/GetGithubSetupStateResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## LinkGithub

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

LinkGithubAccessRequest req = new LinkGithubAccessRequest() {};

var res = await sdk.Github.LinkGithubAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [LinkGithubAccessRequest](../../Models/Operations/LinkGithubAccessRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[LinkGithubAccessResponse](../../Models/Operations/LinkGithubAccessResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## StorePublishingSecrets

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GithubStorePublishingSecretsRequest req = new GithubStorePublishingSecretsRequest() {
    GenerateGenLockId = "<id>",
};

var res = await sdk.Github.StorePublishingSecretsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [GithubStorePublishingSecretsRequest](../../Models/Shared/GithubStorePublishingSecretsRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[GithubStorePublishingSecretsResponse](../../Models/Operations/GithubStorePublishingSecretsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## TriggerAction

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GithubTriggerActionRequest req = new GithubTriggerActionRequest() {
    GenLockId = "<id>",
    Org = "<value>",
    RepoName = "<value>",
};

var res = await sdk.Github.TriggerActionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GithubTriggerActionRequest](../../Models/Shared/GithubTriggerActionRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[GithubTriggerActionResponse](../../Models/Operations/GithubTriggerActionResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |