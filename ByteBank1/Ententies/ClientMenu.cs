
namespace ByteBank1.Ententies;

internal class ClientMenu {

    public static void Show()
    {

        Console.Clear();
        ShowOptions();
        var option = Console.ReadLine();

        HandleMenuOptions(option);
    }
    public static void ShowOptions()
    {


        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("           BiteBank");
        Console.WriteLine("   ==Client.Nome===========");
        Console.WriteLine("   ========================");
        Console.WriteLine("   Saldo da {Client.Saldo}");
        Console.WriteLine("   ========================");
        Console.WriteLine("   1 - Sacar\n");
        Console.WriteLine("   2 - Depositar\n");
        Console.WriteLine("   3 - Tranferir\n");
        Console.WriteLine("   0 - Sair da conta\n");
        Console.WriteLine("   ========================");
        Console.WriteLine();
        Console.Write("   Digite a opção desejada: ");
    }

    public static void HandleMenuOptions(string option)
    {
        switch (option)
        {

            case "1":
                Console.Clear(); Console.WriteLine("\n Deveria estar sacando um valor!");
                Thread.Sleep(2000); ClientMenu.Show(); break;

            case "2":
                Console.Clear(); Console.WriteLine("\n Deveria estar depositando um valor!");
                Thread.Sleep(2000); ClientMenu.Show(); break;

            case "3":
                Console.Clear(); Console.WriteLine("\n Tranferir para outra conta!");
                Thread.Sleep(2000); ClientMenu.Show(); break;

            case "0": Console.Clear(); Menu.Show(); ; break;

            default:
                Console.Clear(); Console.WriteLine("\n Opção inválida!"); Thread.Sleep(1000); Console.WriteLine(" Tente novamente...");
                Thread.Sleep(1000); ClientMenu.Show(); break; //repete o menu caso escolha algo fora do esperado
        }
    }



}

