# Reports
(*Reports*)

## Overview

REST APIs for managing reports

### Available Operations

* [GetChangesReportSignedUrl](#getchangesreportsignedurl) - Get the signed access url for the change reports for a particular document.
* [GetLintingReportSignedUrl](#getlintingreportsignedurl) - Get the signed access url for the linting reports for a particular document.
* [UploadReport](#uploadreport) - Upload a report.

## GetChangesReportSignedUrl

Get the signed access url for the change reports for a particular document.

### Example Usage

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

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## GetLintingReportSignedUrl

Get the signed access url for the linting reports for a particular document.

### Example Usage

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

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## UploadReport

Upload a report.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

UploadReportRequestBody req = new UploadReportRequestBody() {
    Data = new Report() {},
    File = new File() {
        Content = System.Text.Encoding.UTF8.GetBytes("0xA329C0ad85"),
        FileName = "your_file_here",
    },
};

var res = await sdk.Reports.UploadReportAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UploadReportRequestBody](../../Models/Operations/UploadReportRequestBody.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[UploadReportResponse](../../Models/Operations/UploadReportResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |
