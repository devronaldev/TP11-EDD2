namespace TP11_EDD2.Views;

public class Menu
{
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
            case 1: Environment.Exit(1); break;
            case 2: Environment.Exit(2); break;
            case 3: Environment.Exit(3); break;
            case 4: Environment.Exit(4); break;
            case 5: Environment.Exit(5); break;
            case 6: Environment.Exit(6); break;
            case 7: Environment.Exit(7); break;
            case 8: Environment.Exit(8); break;
            case 9: Environment.Exit(9); break;
            case 10: Environment.Exit(10); break;
        }
    }

    private void AddDomain()
    {
        
    }
    
    private void SearchDomain()
    {
        
    }

    private void DeleteDomain()
    {
        
    }

    private void AddUser()
    {
        
    }

    private void SearchUser()
    {
        
    }

    private void DeleteUser()
    {
        
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