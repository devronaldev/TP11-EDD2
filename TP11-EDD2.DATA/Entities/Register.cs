namespace TP11_EDD2.DATA.Entities;

public class Register
{
    public List<User> Users { get; set; }
    public List<Domain> Domains { get; set; }
    
    public void AddUser(User user)
    {
        Users.Add(user);
    }

    public bool DeleteUser(User user)
    {
        return Users.Remove(user);
    }

    public User? SearchUser(User user)
    {
        return Users.FirstOrDefault(u => u.Equals(user));
    }

    public void AddDomain(Domain domain)
    {
        Domains.Add(domain);
    }

    public bool DeleteDomain(Domain domain)
    {
        return Domains.Remove(domain);
    }

    public Domain? SearchDomain(Domain domain)
    {
        return Domains.FirstOrDefault(d => d.Equals(domain));
    }

    public void UploadData()
    {
        
    }
    
    public void DownloadData()
    {
        
    }
}