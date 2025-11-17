using System.Text;

namespace TP11_EDD2.DATA.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Domain> Domains { get; set; }

    public User()
    {
        Domains = new List<Domain>();
    }

    public User(int id, string name) : this()
    {
        Id = id;
        Name = name;
    }

    public bool GivePermission(Domain domain)
    {
        var existingDomain = Domains.FirstOrDefault(d => d.Equals(domain));
        if (existingDomain != null)
        {
            return false;
        }
        Domains.Add(domain);
        return true;
    }

    public bool RevokePermission(Domain domain)
    {
        var existingDomain = Domains.FirstOrDefault(d => d.Equals(domain));
        if (existingDomain != null)
        {
            return Domains.Remove(existingDomain);
        }
        return false;
    }

    public bool Equal(User user)
    {
        if (Id == user.Id)
        {
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Nome: {Name} - Id: {Id}");
        sb.AppendLine($"==/ Ambientes /==");
        foreach (var domain in Domains)
        {
            sb.AppendLine($"Ambiente: {domain.Name} - Id: {domain.Id}");
        }
        return sb.ToString();
    }
}

