using System.Text;

namespace TP11_EDD2.DATA.Entities;

public class Domain
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Queue<Log> Logs { get; set; } = new();

    public void RegistLog(Log log)
    {
        if (Logs.Count == 100)
        {
            Logs.Dequeue();
        }

        Logs.Enqueue(log);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"==/ Ambiente: {Name} /==/ Id: {Id} /==/ LOGS /== ");
        foreach (var log in Logs)
        {
            sb.AppendLine(log.ToString());
        }
        return sb.ToString();
    }
}