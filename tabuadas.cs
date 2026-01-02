namespace Calculator;

public class tabuadas
{
    public static void Calcular()
    {
        string continuar;
      
        do
        {
            Console.Clear();
            Console.WriteLine("Digite o Numero a Ser Multiplicado Pela Tabuada:");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine($"\n===== Tabuada do {num} =====");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{num} x {i} = {num * i}");
                }
                Console.WriteLine("===========================\n");
            }
            else
            {
                Console.WriteLine("X - Digite um Número maior do que ZERO! - X");
            }
         
            Console.WriteLine("\nDeseja calcular outra tabuada? (S/N)");
            continuar = Console.ReadLine()?.ToUpper();
         
        } while (continuar == "S");
    }
}