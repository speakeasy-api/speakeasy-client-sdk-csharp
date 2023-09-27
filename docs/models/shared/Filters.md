# Filters

Filters are used to query requests.


## Fields

| Field                                         | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `Filters`                                     | List<[Filter](../../models/shared/Filter.md)> | :heavy_check_mark:                            | A list of filters to apply to the query.      |
| `Limit`                                       | *long*                                        | :heavy_check_mark:                            | The maximum number of results to return.      |
| `Offset`                                      | *long*                                        | :heavy_check_mark:                            | The offset to start the query from.           |
| `Operator`                                    | *string*                                      | :heavy_check_mark:                            | The operator to use when combining filters.   |