# ReleaseMaker

This is a Terminal User Interface, you will need to run it via command line. So, just clone the repo, cd into GithubReleaseManagement and then run dotnet run.

## Running the App

Make sure to enter the PR Number for the release PR
The repo name
The org/user name
TicketUrlPrefix, you can also enter a config value for this :D

If you want to include down merge PRs in the list, make sure to uncheck the box

Then just generate the list, copy and paste it into a note pad and if you have any PR's without a ticket number, then you will need to go those PRs and figure out what it is.



## Initial Config Setup

You will need to generate a github PAT token with readonly access to Pull Requests. Also add your ticket_url_prefix. 
Then you will need to crate a config.TOML file and have it look like the following

```
ticket_url_prefix = "https://somethingcool"

[token]
value = "{Some cool github PAT}"
```


## Screenshot

![image](https://github.com/user-attachments/assets/7ffcdfda-458c-4c3e-8ec4-229ce96056c6)
