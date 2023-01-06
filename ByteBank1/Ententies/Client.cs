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

    public static void CreateClient() {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("           BiteBank");
        Console.WriteLine("   ========================");
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


}


