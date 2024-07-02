# SuggestOperationIDsRegistryRequest


## Fields

| Field                                                                     | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `NamespaceName`                                                           | *string*                                                                  | :heavy_check_mark:                                                        | N/A                                                                       |
| `RevisionReference`                                                       | *string*                                                                  | :heavy_check_mark:                                                        | Tag or digest                                                             |
| `XSessionId`                                                              | *string*                                                                  | :heavy_check_mark:                                                        | N/A                                                                       |
| `SuggestOperationIDsOpts`                                                 | [SuggestOperationIDsOpts](../../Models/Shared/SuggestOperationIDsOpts.md) | :heavy_minus_sign:                                                        | The schema file to upload provided as a multipart/form-data file segment. |
| `Limit`                                                                   | *double*                                                                  | :heavy_minus_sign:                                                        | Max number of suggestions to request                                      |