# AccessToken

An AccessToken is a token that can be used to authenticate with the Speakeasy API.


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `AccessToken`                                                       | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `Claims`                                                            | [Claims](../../Models/Shared/Claims.md)                             | :heavy_check_mark:                                                  | N/A                                                                 |
| `FeatureFlags`                                                      | List<[FeatureFlag](../../Models/Shared/FeatureFlag.md)>             | :heavy_minus_sign:                                                  | N/A                                                                 |
| `User`                                                              | [AccessTokenUser](../../Models/Shared/AccessTokenUser.md)           | :heavy_check_mark:                                                  | N/A                                                                 |
| `Workspaces`                                                        | List<[Models.Shared.Workspaces](../../Models/Shared/Workspaces.md)> | :heavy_minus_sign:                                                  | N/A                                                                 |