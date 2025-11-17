namespace TP11_EDD2.DATA.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Domain> Environments { get; set; }

    public User()
    {
        Environments = new List<Domain>();
    }

    public User(int id, string name) : this()
    {
        Id = id;
        Name = name;
    }

    public bool GivePermission(Domain domain)
    {
        var existingDomain = Environments.FirstOrDefault(d => d.Equals(domain));
        if (existingDomain != null)
        {
            return false;
        }
        Environments.Add(domain);
        return true;
    }

    public bool RevokePermission(Domain domain)
    {
        var existingDomain = Environments.FirstOrDefault(d => d.Equals(domain));
        if (existingDomain != null)
        {
            return Environments.Remove(existingDomain);
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
}

