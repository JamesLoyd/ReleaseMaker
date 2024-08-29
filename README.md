# ReleaseMaker

This is a Terminal User Interface, you will need to run it via command line. So, just clone the repo, cd into GithubReleaseManagement and then run dotnet run.

## Running the App

Make sure to enter the PR Number for the release PR
The repo name
The org/user name

If you want to include down merge PRs in the list, make sure to uncheck the box

Then just generate the list, copy and paste it into a note pad and if you have any PR's without a ticket number, then you will need to go those PRs and figure out what it is.



## Initial Config Setup

You will need to generate a github PAT token with readonly access to Pull Requests.
Then you will need to crate a config.TOML file and have it look like the following

```
[token]
value = "{Some cool github PAT}"
```


## Screenshot

![image](https://github.com/user-attachments/assets/edf0e4c1-2d14-4a57-9719-37f5d60169b4)
