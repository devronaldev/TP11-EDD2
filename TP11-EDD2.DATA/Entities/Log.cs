namespace TP11_EDD2.DATA.Entities;

public class Log
{
    public DateTime AccessDate { get; set; }
    public User User { get; set; }
    public bool IsAuthorized { get; set; }

    public Log(User user, bool isAuthorized)
    {
        AccessDate = DateTime.UtcNow;
        User = user;
        IsAuthorized = isAuthorized; 
    }
}