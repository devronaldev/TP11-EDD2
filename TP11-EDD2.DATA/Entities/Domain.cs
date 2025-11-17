namespace TP11_EDD2.DATA.Entities;

public class Domain
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Queue<Log> Logs { get; set; }

    public Domain()
    {
        Logs = new Queue<Log>();
    }

    public Domain(int id, string name) : this()
    {
        Id = id;
        Name = name;
    }
    
    public void RegistLog(Log log)
    {
        if (Logs.Count == 100)
        {
            Logs.Dequeue();
        }

        Logs.Enqueue(log);
    }
}