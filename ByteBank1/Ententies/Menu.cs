namespace ByteBank1.Ententies
{
    public class Menu
    {
        public static void Show()
        {

            Console.Clear();
            WriteOptions();
            var option = int.Parse(Console.ReadLine());

            HandleMenuOptions(option);
        }
        public static void WriteOptions()
        {

            Console.WriteLine();
            Console.WriteLine("           BiteBank");
            Console.WriteLine("   ========================");
            Console.WriteLine("  Selecione uma opção abaixo:");
            Console.WriteLine("   ========================");
            Console.WriteLine("  1 - Inserir novo usuário\n");
            Console.WriteLine("  2 - Deletar um usuário\n");
            Console.WriteLine("  3 - Detalhes de um usuário\n");
            Console.WriteLine("  4 - Total armazenado no banco\n");
            Console.WriteLine("  0 - Para sair do programa");
            Console.WriteLine("   ========================");
            Console.WriteLine();
            Console.Write("  Digite a opção desejada: ");
        }

        public static void HandleMenuOptions(int option)
        {
            switch (option)
            {
                case 0:
                    Console.WriteLine("Estou encerrando o programa...");
                    break;
                case 1:
                    Console.WriteLine("Deveria estar inserindo um novo usario!");
                    break;
                case 2:
                    Console.WriteLine("Deveria estar deletando um usuário!");
                    break;
                case 3:
                    Console.WriteLine("Deveria estar detalhando os usario!");
                    break;
                case 4:
                    Console.WriteLine("Deveria estar mostrando o total do Banco!");
                    break;
            }



        }





    }
}
