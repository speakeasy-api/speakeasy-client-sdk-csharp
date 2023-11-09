# SchemaDiff

A SchemaDiff represents a diff of two Schemas.


## Fields

| Field                                                                 | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `Additions`                                                           | List<*string*>                                                        | :heavy_check_mark:                                                    | Holds every addition change in the diff.                              |
| `Deletions`                                                           | List<*string*>                                                        | :heavy_check_mark:                                                    | Holds every deletion change in the diff.                              |
| `Modifications`                                                       | Dictionary<String, [ValueChange](../../Models/Shared/ValueChange.md)> | :heavy_check_mark:                                                    | Holds every modification change in the diff.                          |