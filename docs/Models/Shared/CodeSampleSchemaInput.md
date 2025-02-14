# CodeSampleSchemaInput


## Fields

| Field                                                 | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `Language`                                            | *string*                                              | :heavy_check_mark:                                    | The language to generate code samples for             |
| `SchemaFile`                                          | [SchemaFile](../../Models/Shared/SchemaFile.md)       | :heavy_check_mark:                                    | The OpenAPI file to be uploaded                       |
| `OperationIds`                                        | List<*string*>                                        | :heavy_minus_sign:                                    | A list of operations IDs to generate code samples for |
| `PackageName`                                         | *string*                                              | :heavy_minus_sign:                                    | The name of the package                               |
| `SDKClassName`                                        | *string*                                              | :heavy_minus_sign:                                    | The SDK class name                                    |