<!-- Start SDK Example Usage [usage] -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using System;
using System.Collections.Generic;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

CodeSampleSchemaInput req = new CodeSampleSchemaInput() {
    Languages = new List<string>() {
        "<value>",
    },
    SchemaFile = new SchemaFile() {
        Content = System.Text.Encoding.UTF8.GetBytes("0xc3dD8BfBef"),
        FileName = "example.file",
    },
};

var res = await sdk.GenerateCodeSamplePreviewAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->