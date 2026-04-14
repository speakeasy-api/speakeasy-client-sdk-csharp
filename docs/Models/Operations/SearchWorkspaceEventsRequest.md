# SearchWorkspaceEventsRequest


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `WorkspaceId`                                              | *string*                                                   | :heavy_minus_sign:                                         | Unique identifier of the workspace.                        |
| `SourceRevisionDigest`                                     | *string*                                                   | :heavy_minus_sign:                                         | Unique identifier of the source revision digest.           |
| `LintReportDigest`                                         | *string*                                                   | :heavy_minus_sign:                                         | Unique identifier of the lint report digest.               |
| `OpenapiDiffReportDigest`                                  | *string*                                                   | :heavy_minus_sign:                                         | Unique identifier of the openapi diff report digest.       |
| `InteractionType`                                          | [InteractionType](../../Models/Shared/InteractionType.md)  | :heavy_minus_sign:                                         | Specified interaction type for events.                     |
| `GenerateGenLockId`                                        | *string*                                                   | :heavy_minus_sign:                                         | A specific gen lock ID for the events.                     |
| `ExecutionId`                                              | *string*                                                   | :heavy_minus_sign:                                         | Shared execution ID for cli events across a single action. |
| `Success`                                                  | *bool*                                                     | :heavy_minus_sign:                                         | Whether the event was successful or not.                   |
| `Limit`                                                    | *long*                                                     | :heavy_minus_sign:                                         | Number of results to return.                               |