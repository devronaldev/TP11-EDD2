using TP11_EDD2.DATA.Entities;

namespace TP11_EDD2.Views;

public class Menu
{
    Register _register = new Register(); 
    public void Init()
    {
        while (true)
        {
            ShowOptions();
        }
    }

    private void ShowOptions()
    {
        Console.Clear();
        Console.WriteLine("==== // Bem-vindo ao menu! // ====");
        Console.WriteLine("0. Sair.");
        Console.WriteLine("1. Cadastrar Ambiente.");
        Console.WriteLine("2. Consultar Ambiente.");
        Console.WriteLine("3. Excluir Ambiente.");
        Console.WriteLine("4. Cadastrar Usuário.");
        Console.WriteLine("5. Consultar Usuario.");
        Console.WriteLine("6. Excluir Usuário.");
        Console.WriteLine("7. Conceder permissão.");
        Console.WriteLine("8. Revogar Permissão.");
        Console.WriteLine("9. Registrar Acesso.");
        Console.WriteLine("10. Consultar Logs.");

        var optionNumber = MenuHelper.ReadInt("Digite o número desejado: ", 0, 10);
        SwitchOptions(optionNumber);
        MenuHelper.ClickAnyKey();
    }

    private void SwitchOptions(int optionNumber)
    {
        switch (optionNumber)
        {
            case 0: Environment.Exit(0); break;
            case 1: AddDomain(); break;
            case 2: SearchDomain(); break;
            case 3: DeleteDomain(); break;
            case 4: AddUser(); break;
            case 5: SearchUser(); break;
            case 6: DeleteUser(); break;
            case 7: GivePermission(); break;
            case 8: RevokePermission(); break;
            case 9: RegisterAccess(); break;
            case 10: ShowLogs(); break;
        }
    }

    private void AddDomain()
    {
        Console.Write("Insira o nome do ambiente: ");
        var name = Console.ReadLine();
        var domain = new Domain{Name = name};
        _register.AddDomain(domain);
        Console.WriteLine("Ambiente adicionado com sucesso!");
    }
    
    private void SearchDomain()
    {
        Console.Write("Insira o nome do ambiente: ");
        var name = Console.ReadLine();
        var domain = new Domain{Name = name};
        var foundDomain = _register.SearchDomain(domain);
        if (foundDomain == null)
        {
            Console.WriteLine("Dominio não encontrado.");
        }
        else
        {
            Console.WriteLine(foundDomain.ToString());
        }
    }

    private void DeleteDomain()
    {
        Console.WriteLine("Insira o nome do ambiente: ");
        var name = Console.ReadLine();
        var domain = new Domain{Name = name};

        if (!_register.DeleteDomain(domain))
        {
            Console.WriteLine("Erro ao remover ambiente!");
        }
        else
        {
            Console.WriteLine("Ambiente removido com sucesso!");
        }
    }

    private void AddUser()
    {
        Console.Write("Insira o nome do usuário: ");
        var name = Console.ReadLine();
        var user = new User{Name = name};
        _register.AddUser(user);
        Console.WriteLine("Usuário registrado com sucesso.");
    }

    private void SearchUser()
    {
        Console.Write("Insira o nome do usuário: ");
        var name = Console.ReadLine();
        var user = new User{Name = name};
        var foundUser = _register.SearchUser(user);
        if (foundUser == null)
        {
            Console.WriteLine("Usuário não encontrado.");
        }
        else
        {
            Console.WriteLine(foundUser.ToString());
        }
    }

    private void DeleteUser()
    {
        Console.Write("Insira o nome do usuário: ");
        var name = Console.ReadLine();
        var user = new User{Name = name};
        var foundUser = _register.SearchUser(user);
        if (foundUser == null)
        {
            Console.WriteLine("Usuário não encontrado.");
        }

        if (_register.DeleteUser(foundUser))
        {
            Console.WriteLine("Usuário deletado com sucesso!");
        }
        else
        {
            Console.WriteLine("Usuário não deletado! Verifique se ele ainda tem permissões!");
        }
    }

    private void GivePermission()
    {
        
    }

    private void RevokePermission()
    {
        
    }

    private void RegisterAccess()
    {
        
    }

    private void ShowLogs()
    {
        
    }
}