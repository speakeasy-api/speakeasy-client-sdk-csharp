# OrganizationUsageResponse

A billing summary of organization usage


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `AllowedLanguages`                                                                    | List<*string*>                                                                        | :heavy_check_mark:                                                                    | List of allowed languages                                                             |
| `FreeTrialExpiry`                                                                     | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | Expiry date of the free trial, will be null if no trial                               |
| `TotalAllowedLanguages`                                                               | *long*                                                                                | :heavy_check_mark:                                                                    | Total number of allowed languages, -1 if unlimited                                    |
| `Usage`                                                                               | List<[OrganizationUsage](../../Models/Shared/OrganizationUsage.md)>                   | :heavy_check_mark:                                                                    | N/A                                                                                   |