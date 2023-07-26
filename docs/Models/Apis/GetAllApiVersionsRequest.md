# GetAllApiVersionsRequest


## Fields

| Field                                                           | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `apiID`                                                         | *string*                                                        | :heavy_check_mark:                                              | The ID of the Api to retrieve.                                  |
| `metadata`                                                      | Dictionary<String, List<*string*>   !!!>                        | :heavy_minus_sign:                                              | Metadata to filter Apis on                                      |
| `op`                                                            | [GetAllApiVersionsOp](../../Models/Apis/GetAllApiVersionsOp.md) | :heavy_minus_sign:                                              | Configuration for filter operations                             |