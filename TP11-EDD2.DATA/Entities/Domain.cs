namespace TP11_EDD2.DATA.Entities;

public class Domain
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Queue<Log> Logs { get; set; }
    
    public void RegistLog(Log log)
    {
        Logs.Enqueue(log);
    }
}