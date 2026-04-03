# Github

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

<!-- UsageSnippet language="csharp" operationID="checkGithubAccess" method="get" path="/v1/github/check_access" -->
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

<!-- UsageSnippet language="csharp" operationID="githubCheckPublishingPRs" method="get" path="/v1/github/publishing_prs" -->
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

<!-- UsageSnippet language="csharp" operationID="githubCheckPublishingSecrets" method="get" path="/v1/github/publishing_secrets" -->
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

<!-- UsageSnippet language="csharp" operationID="githubConfigureCodeSamples" method="post" path="/v1/github/configure_code_samples" -->
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

<!-- UsageSnippet language="csharp" operationID="githubConfigureMintlifyRepo" method="post" path="/v1/github/configure_mintlify_repo" -->
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
        "<value 1>",
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

<!-- UsageSnippet language="csharp" operationID="githubConfigureTarget" method="post" path="/v1/github/configure_target" -->
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

<!-- UsageSnippet language="csharp" operationID="getGitHubAction" method="get" path="/v1/github/action" -->
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

<!-- UsageSnippet language="csharp" operationID="getGithubSetupState" method="get" path="/v1/github/setup" -->
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

<!-- UsageSnippet language="csharp" operationID="linkGithubAccess" method="post" path="/v1/github/link" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

LinkGithubAccessRequest? req = null;

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

<!-- UsageSnippet language="csharp" operationID="githubStorePublishingSecrets" method="post" path="/v1/github/publishing_secrets" -->
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

<!-- UsageSnippet language="csharp" operationID="githubTriggerAction" method="post" path="/v1/github/trigger_action" -->
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