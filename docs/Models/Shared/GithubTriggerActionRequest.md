# GithubTriggerActionRequest

A request to trigger an action on a GitHub target


## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `GenLockId`                                            | *string*                                               | :heavy_check_mark:                                     | The generation lock ID                                 |
| `Org`                                                  | *string*                                               | :heavy_check_mark:                                     | The GitHub organization name                           |
| `RepoName`                                             | *string*                                               | :heavy_check_mark:                                     | The GitHub repository name                             |
| `Force`                                                | *bool*                                                 | :heavy_minus_sign:                                     | Force an SDK generation                                |
| `SetVersion`                                           | *string*                                               | :heavy_minus_sign:                                     | A version to override the SDK too in workflow dispatch |
| `TargetName`                                           | *string*                                               | :heavy_minus_sign:                                     | The target name for the action                         |