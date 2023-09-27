# UpsertApiEndpointRequest


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `ApiEndpointInput`                                          | [ApiEndpointInput](../../models/shared/ApiEndpointInput.md) | :heavy_check_mark:                                          | A JSON representation of the ApiEndpoint to upsert.         |
| `ApiEndpointID`                                             | *string*                                                    | :heavy_check_mark:                                          | The ID of the ApiEndpoint to upsert.                        |
| `ApiID`                                                     | *string*                                                    | :heavy_check_mark:                                          | The ID of the Api the ApiEndpoint belongs to.               |
| `VersionID`                                                 | *string*                                                    | :heavy_check_mark:                                          | The version ID of the Api the ApiEndpoint belongs to.       |