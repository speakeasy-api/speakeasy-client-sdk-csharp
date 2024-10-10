# GetWorkspaceTargetsDeprecatedRequest


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `WorkspaceId`                                                                         | *string*                                                                              | :heavy_check_mark:                                                                    | Unique identifier of the workspace.                                                   |
| `AfterLastEventCreatedAt`                                                             | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | Filter to only return targets with events created after this timestamp                |