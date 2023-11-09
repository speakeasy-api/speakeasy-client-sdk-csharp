# FindApiEndpointRequest


## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `ApiID`                                                                              | *string*                                                                             | :heavy_check_mark:                                                                   | The ID of the Api the ApiEndpoint belongs to.                                        |
| `DisplayName`                                                                        | *string*                                                                             | :heavy_check_mark:                                                                   | The displayName of the ApiEndpoint to find (set by operationId from OpenAPI schema). |
| `VersionID`                                                                          | *string*                                                                             | :heavy_check_mark:                                                                   | The version ID of the Api the ApiEndpoint belongs to.                                |