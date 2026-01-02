namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("-------------------");
            Console.WriteLine("Escolha a Opção:");
            Console.WriteLine("1 - Calcular Valores");
            Console.WriteLine("2 - Calcular Tabuadas");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("-------------------");
            
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                calcVal.Calcular();
            }
            else if (opcao == 2)
            {
                tabuadas.Calcular();
            }
            else if (opcao == 3)
            {
                Console.Clear();
                Console.WriteLine("= PROGRAMA ENCERRADO =");
                Console.WriteLine("\nAté a proxima!");
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("X - Opção Invalida, tente novamente! - X");
            }

        }
    }
}