using ByteBank1.Ententies;

namespace ByteBank1
{


    public class Program
    {



        public static void Main(string[] args)
        {

            Console.WriteLine("Antes de começar a usar, vamos configurar alguns valores...");

            Console.Write("Digite a quantidade de Usuários: ");
            int quantidadeDeUsuarios = int.Parse(Console.ReadLine());

            Menu.Show();



        }

    }

}