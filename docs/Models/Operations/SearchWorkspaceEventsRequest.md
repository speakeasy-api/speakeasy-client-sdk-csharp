# SearchWorkspaceEventsRequest


## Fields

| Field                                                     | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `GenerateGenLockId`                                       | *string*                                                  | :heavy_minus_sign:                                        | A specific gen lock ID for the events.                    |
| `InteractionType`                                         | [InteractionType](../../Models/Shared/InteractionType.md) | :heavy_minus_sign:                                        | Specified interaction type for events.                    |
| `LintReportDigest`                                        | *string*                                                  | :heavy_minus_sign:                                        | Unique identifier of the lint report digest.              |
| `OpenapiDiffReportDigest`                                 | *string*                                                  | :heavy_minus_sign:                                        | Unique identifier of the openapi diff report digest.      |
| `SourceRevisionDigest`                                    | *string*                                                  | :heavy_minus_sign:                                        | Unique identifier of the source revision digest.          |
| `WorkspaceID`                                             | *string*                                                  | :heavy_minus_sign:                                        | Unique identifier of the workspace.                       |