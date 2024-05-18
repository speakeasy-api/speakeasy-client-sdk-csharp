# GithubTriggerActionRequest

A request to trigger an action on a GitHub target


## Fields

| Field                          | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `GenLockId`                    | *string*                       | :heavy_check_mark:             | The generation lock ID         |
| `Org`                          | *string*                       | :heavy_check_mark:             | The GitHub organization name   |
| `RepoName`                     | *string*                       | :heavy_check_mark:             | The GitHub repository name     |
| `TargetName`                   | *string*                       | :heavy_minus_sign:             | The target name for the action |