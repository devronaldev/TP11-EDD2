namespace TP11_EDD2.DATA.Entities;

public class Register
{
    public List<User> Users { get; set; }
    public List<Domain> Domains { get; set; }
    
    public void AddUser(User user)
    {
        user.Id = Users.Any() ? Users.Max(u => u.Id) + 1 : 1;
        Users.Add(user);
    }

    public bool DeleteUser(User user)
    {
        var userToDelete = SearchUser(user);
        if (userToDelete == null)
        {
            return false;
        }
        if (userToDelete.Domains.Any())
        {
            return false;
        }
        return Users.Remove(userToDelete);
    }

    public User? SearchUser(User user)
    {
        return Users.FirstOrDefault(u => u.Equals(user));
    }

    public void AddDomain(Domain domain)
    {
        domain.Id = Domains.Any() ? Domains.Max(d => d.Id) + 1 : 1;
        Domains.Add(domain);
    }

    public bool DeleteDomain(Domain domain)
    {
        var domainToDelete = SearchDomain(domain);
        if (domainToDelete == null)
        {
            return false;
        }
        return Domains.Remove(domain);
    }

    public Domain? SearchDomain(Domain domain)
    {
        return Domains.FirstOrDefault(d => d.Equals(domain));
    }

    public void UploadData()
    {
        //TODO: IMPLEMENT WHEN YOU CREATE INFRA LAYER
    }
    
    public void DownloadData()
    {
        //TODO: IMPLEMENT WHEN YOU CREATE INFRA LAYER
    }
}