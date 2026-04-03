# UpdatePublishingTokenExpirationRequestBody

The publishing token to update


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `TokenName`                                                                           | *string*                                                                              | :heavy_minus_sign:                                                                    | The new name for the publishing token.                                                |
| `ValidUntil`                                                                          | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_check_mark:                                                                    | The new expiration date for the publishing token.                                     |