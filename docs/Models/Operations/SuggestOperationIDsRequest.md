# SuggestOperationIDsRequest


## Fields

| Field                                                                                       | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `RequestBody`                                                                               | [SuggestOperationIDsRequestBody](../../Models/Operations/SuggestOperationIDsRequestBody.md) | :heavy_check_mark:                                                                          | The schema file to upload provided as a multipart/form-data file segment.                   |
| `XSessionId`                                                                                | *string*                                                                                    | :heavy_check_mark:                                                                          | N/A                                                                                         |
| `Limit`                                                                                     | *double*                                                                                    | :heavy_minus_sign:                                                                          | Max number of suggestions to request                                                        |