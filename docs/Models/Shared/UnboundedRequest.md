# UnboundedRequest

An UnboundedRequest represents the HAR content capture by Speakeasy when logging a request.


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `CreatedAt`                                                                           | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_check_mark:                                                                    | Creation timestamp.                                                                   |
| `Har`                                                                                 | *string*                                                                              | :heavy_check_mark:                                                                    | The HAR content of the request.                                                       |
| `HarSizeBytes`                                                                        | *long*                                                                                | :heavy_check_mark:                                                                    | The size of the HAR content in bytes.                                                 |
| `RequestId`                                                                           | *string*                                                                              | :heavy_check_mark:                                                                    | The ID of this request.                                                               |
| `WorkspaceId`                                                                         | *string*                                                                              | :heavy_check_mark:                                                                    | The workspace ID this request was made to.                                            |