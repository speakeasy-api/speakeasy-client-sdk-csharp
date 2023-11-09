# GetAllApiVersionsRequest


## Fields

| Field                               | Type                                | Required                            | Description                         |
| ----------------------------------- | ----------------------------------- | ----------------------------------- | ----------------------------------- |
| `ApiID`                             | *string*                            | :heavy_check_mark:                  | The ID of the Api to retrieve.      |
| `Metadata`                          | Dictionary<String, List<*string*>>  | :heavy_minus_sign:                  | Metadata to filter Apis on          |
| `Op`                                | [Op](../../Models/Operations/Op.md) | :heavy_minus_sign:                  | Configuration for filter operations |