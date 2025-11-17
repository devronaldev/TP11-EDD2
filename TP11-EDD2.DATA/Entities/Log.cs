namespace TP11_EDD2.DATA.Entities;

public class Log
{
    public DateTime AccessDate { get; set; }
    public User User { get; set; }
    public bool isAuthorized { get; set; }
}