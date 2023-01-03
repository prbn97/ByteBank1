using ByteBank1.Ententies;

namespace ByteBank1;



public class Program { 
    public static void Main(string[] args) {

        Console.WriteLine();
        Console.WriteLine("    Bem vindo ao BiteBank!");
        Console.WriteLine("   ========================");
        Console.WriteLine("   Antes de começar a usar, "); Thread.Sleep(1000);
        Console.WriteLine("   vamos configurar algumas coisas...");
        Console.WriteLine("   ========================"); Thread.Sleep(2000);

        Console.Write("\n   Digite a quantidade de Usuários: ");
        int quantidadeDeUsuarios = int.Parse(Console.ReadLine());

        Thread.Sleep(1000);
        Menu.Show();





    }
}