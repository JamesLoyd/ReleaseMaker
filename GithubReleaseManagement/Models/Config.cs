namespace GithubReleaseManagement.Models;

public class Config
{
    public Token Token { get; set; }
    public string TicketUrlPrefix { get; set; } = "";
}

public class Token
{
    public string Value { get; set; }
}