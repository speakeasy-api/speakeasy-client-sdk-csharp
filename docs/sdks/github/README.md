# Github
(*Github*)

### Available Operations

* [GithubCheckAccess](#githubcheckaccess)
* [GithubConfigureTarget](#githubconfiguretarget)
* [GithubTriggerAction](#githubtriggeraction)

## GithubCheckAccess

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

GithubCheckAccessRequest req = new GithubCheckAccessRequest() {
    Org = "<value>",
    Repo = "<value>",
};

var res = await sdk.Github.GithubCheckAccessAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GithubCheckAccessRequest](../../Models/Operations/GithubCheckAccessRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[GithubCheckAccessResponse](../../Models/Operations/GithubCheckAccessResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## GithubConfigureTarget

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new Speakeasy(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

GithubConfigureTargetRequest req = new GithubConfigureTargetRequest() {
    Org = "<value>",
    RepoName = "<value>",
};

var res = await sdk.Github.GithubConfigureTargetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GithubConfigureTargetRequest](../../Models/Shared/GithubConfigureTargetRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[GithubConfigureTargetResponse](../../Models/Operations/GithubConfigureTargetResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## GithubTriggerAction

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new Speakeasy(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

GithubTriggerActionRequest req = new GithubTriggerActionRequest() {
    GenLockId = "<value>",
    Org = "<value>",
    RepoName = "<value>",
};

var res = await sdk.Github.GithubTriggerActionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GithubTriggerActionRequest](../../Models/Shared/GithubTriggerActionRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[GithubTriggerActionResponse](../../Models/Operations/GithubTriggerActionResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |
