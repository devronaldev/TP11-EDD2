namespace TP11_EDD2.Views;

public static class MenuHelper
{
    public static int ReadInt(string message, int min = 0, int max = 999)
    {
        while (true)
        {
            Console.Write(message);

            if (int.TryParse(Console.ReadLine(), out var value))
            {
                if (value >= min && value <= max)
                {
                    return value; 
                }
                else
                {
                    Console.WriteLine($"Valor inválido. O número deve estar entre {min} e {max}.");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido! Digite apenas números.");
            }
        
            Console.WriteLine("Tente novamente.");
        }
    }
    
    public static void ClickAnyKey()
    {
        Console.WriteLine("Clique em qualquer tecla para retornar ao menu.");
        Console.ReadKey();
    }
}