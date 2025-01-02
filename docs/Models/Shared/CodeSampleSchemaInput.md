# CodeSampleSchemaInput


## Fields

| Field                                            | Type                                             | Required                                         | Description                                      |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| `Languages`                                      | List<*string*>                                   | :heavy_check_mark:                               | A list of languages to generate code samples for |
| `SchemaFile`                                     | [SchemaFile](../../Models/Shared/SchemaFile.md)  | :heavy_check_mark:                               | The OpenAPI file to be uploaded                  |
| `PackageName`                                    | *string*                                         | :heavy_minus_sign:                               | The name of the package                          |
| `SDKClassName`                                   | *string*                                         | :heavy_minus_sign:                               | The SDK class name                               |