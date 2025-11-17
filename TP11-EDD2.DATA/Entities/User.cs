namespace TP11_EDD2.DATA.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Domain> Environments { get; set; }

    public bool GivePermission()
    {
        return true;
    }

    public bool RevokePermission()
    {
        return true;
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

