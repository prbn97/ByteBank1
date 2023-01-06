namespace ByteBank1.Ententies;

public class Client {

    public string CPF { get; set; } //atributos ja com os metodos get e set
    public string Name { get; set; }
    public string PassWord { get; set; }

    public Client(string cpf, string name, string password) //construtor
    {
        CPF = cpf;
        Name = name;
        PassWord = password; 
    }

    public static void CreateAccount() {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("           BiteBank");
        Console.WriteLine("   ========================");
        Console.WriteLine("    Nova conta, bem vindo!");
        Console.WriteLine();
        Console.Write("   CPF: ");
        string inputCPF = Convert.ToString(Console.ReadLine());
        Console.Write("   Nome: ");
        string inputName = Convert.ToString(Console.ReadLine());
        Console.Write("   Senha: ");
        string inputPassWord = Convert.ToString(Console.ReadLine());

        var novoCliente = new Client(inputCPF, inputName, inputPassWord);
    }

    public static void Sacar() { }
    public static void Depositar() { }
    public static void Transferir() { }

    public static void RemoveAccountMenuShow()
    {
        Console.Clear();
        RemoveAccountShowOption();
        var decision = Console.ReadLine();

        RemoveAccountHandleOption(decision);
    }
    public static void RemoveAccountShowOption() {

        string decision;

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("           BiteBank");
        Console.WriteLine("   ========================");
        Console.WriteLine("      Confirma exclusão?");
        Console.WriteLine();
        Console.WriteLine("     1- Sim       2- Não");
        Console.WriteLine();
        Console.Write("        opção: ");
    }

    public static void RemoveAccountHandleOption(string decision)
    {
        
        switch (decision)
        {
            case "1" : Console.WriteLine("\n  *exccluir conta"); Thread.Sleep(2000); Menu.Show(); break;
            case "2" : ClientMenu.Show(); break;
            default: 
                { Console.Clear(); Console.WriteLine("\n Opção inválida!");
                Thread.Sleep(1000); Console.WriteLine(" Tente novamente...");
                Thread.Sleep(1000); RemoveAccountMenuShow(); break; }
        }
        
       


    }
}


