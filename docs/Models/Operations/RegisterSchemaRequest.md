# RegisterSchemaRequest


## Fields

| Field                                                                             | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `RequestBody`                                                                     | [RegisterSchemaRequestBody](../../Models/Operations/RegisterSchemaRequestBody.md) | :heavy_check_mark:                                                                | The schema file to upload provided as a multipart/form-data file segment.         |
| `ApiID`                                                                           | *string*                                                                          | :heavy_check_mark:                                                                | The ID of the Api to get the schema for.                                          |
| `VersionID`                                                                       | *string*                                                                          | :heavy_check_mark:                                                                | The version ID of the Api to delete metadata for.                                 |