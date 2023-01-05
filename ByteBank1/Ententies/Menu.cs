namespace ByteBank1.Ententies;

public class Menu
{
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
        Console.WriteLine("   ========================");
        Console.WriteLine("   Selecione uma opção abaixo:");
        Console.WriteLine("   ========================");
        Console.WriteLine("   1 - Acessar Conta\n");
        Console.WriteLine("   2 - Inserir novo usuário\n");
        Console.WriteLine("   3 - Deletar um usuário\n");
        Console.WriteLine("   4 - Detalhes de um usuário\n");
        Console.WriteLine("   5 - Total armazenado no banco\n");
        Console.WriteLine("   0 - Para sair do programa");
        Console.WriteLine("   ========================");
        Console.WriteLine();
        Console.Write("   Digite a opção desejada: ");
    }

    public static void HandleMenuOptions(string option)
    {
        switch (option)
        {

            case "1":
                Console.Clear(); Console.WriteLine("\n Deveria estar validando o acesso da conta!");
                Thread.Sleep(2000); ClientMenu.Show(); break;

            case "2": 
                Console.Clear();Console.WriteLine("\n Deveria estar criando um usuário!");
                Thread.Sleep(2000); Menu.Show(); break;

            case "3": 
                Console.Clear(); Console.WriteLine("\n Deveria estar deletando um usuário!");
                Thread.Sleep(2000); Menu.Show(); break; 

            case "4": 
                Console.Clear(); Console.WriteLine("\n Deveria estar detalhando um usario!");
                Thread.Sleep(2000); Menu.Show(); break; 

            case "5":
                Console.Clear(); Console.WriteLine("\n Deveria estar mostrando o total do Banco!");
                Thread.Sleep(2000); Menu.Show(); break;

            case "0": Console.Clear(); Environment.Exit(0); ; break; 

            default: Console.Clear(); Console.WriteLine("\n Opção inválida!"); Thread.Sleep(1000); Console.WriteLine(" Tente novamente...");
                Thread.Sleep(1000); Menu.Show(); break; //repete o menu caso escolha algo fora de 0-4
            }
        }



    }






