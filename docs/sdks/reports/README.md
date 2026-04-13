# Reports

## Overview

REST APIs for managing reports (lint reports, change reports, etc)

### Available Operations

* [GetChangesReportSignedUrl](#getchangesreportsignedurl) - Get the signed access url for the change reports for a particular document.
* [GetLintingReportSignedUrl](#getlintingreportsignedurl) - Get the signed access url for the linting reports for a particular document.
* [UploadReport](#uploadreport) - Upload a report.

## GetChangesReportSignedUrl

Get the signed access url for the change reports for a particular document.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getChangesReportSignedUrl" method="get" path="/v1/reports/changes/{documentChecksum}" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetChangesReportSignedUrlRequest req = new GetChangesReportSignedUrlRequest() {
    DocumentChecksum = "<value>",
};

var res = await sdk.Reports.GetChangesReportSignedUrlAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [GetChangesReportSignedUrlRequest](../../Models/Operations/GetChangesReportSignedUrlRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[GetChangesReportSignedUrlResponse](../../Models/Operations/GetChangesReportSignedUrlResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetLintingReportSignedUrl

Get the signed access url for the linting reports for a particular document.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLintingReportSignedUrl" method="get" path="/v1/reports/linting/{documentChecksum}" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetLintingReportSignedUrlRequest req = new GetLintingReportSignedUrlRequest() {
    DocumentChecksum = "<value>",
};

var res = await sdk.Reports.GetLintingReportSignedUrlAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [GetLintingReportSignedUrlRequest](../../Models/Operations/GetLintingReportSignedUrlRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[GetLintingReportSignedUrlResponse](../../Models/Operations/GetLintingReportSignedUrlResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## UploadReport

Upload a report.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="uploadReport" method="post" path="/v1/reports" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

UploadReportRequest req = new UploadReportRequest() {
    Data = new Report() {},
    File = new SpeakeasySDK.Models.Operations.File() {
        Content = System.IO.File.ReadAllBytes("example.file"),
        FileName = "example.file",
    },
};

var res = await sdk.Reports.UploadReportAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [UploadReportRequest](../../Models/Operations/UploadReportRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[UploadReportResponse](../../Models/Operations/UploadReportResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |