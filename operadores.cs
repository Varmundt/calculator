namespace Calculator;

public enum Operacao
{
    Somar = 1,
    Subtrair = 2,
    Multiplicar = 3,
    Dividir = 4
}

public class operadores
{
    public static void Somar(int num1, int num2)
    {Console.WriteLine(num1 + num2);}
    public static void Subtrair(int num1, int num2)
    {Console.WriteLine(num1 - num2);}
    public static void Dividir(int num1, int num2)
    {Console.WriteLine(num1 / num2);}
    public static void Multiplicar(int num1, int num2)
    {Console.WriteLine(num1 * num2);}
}

public class calcVal
{ 
    public static void Calcular()
    {
        string continuar;

        do
        {
            Console.Clear();
            Console.WriteLine("--- MENU CALCULAR ---");
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("-------------------");

            int opcao = int.Parse(Console.ReadLine());
            
            Console.Clear();
            Console.WriteLine("= Digite o primeiro numero =");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n== Digite o segundo numero ==");
            int num2 = int.Parse(Console.ReadLine());

            switch ((Operacao)opcao)
            {
                case Operacao.Somar:
                    Console.WriteLine("\nResultado:");
                    operadores.Somar(num1, num2);
                    break;

                case Operacao.Subtrair:
                    Console.WriteLine("\nResultado:");
                    operadores.Subtrair(num1, num2);
                    break;

                case Operacao.Multiplicar:
                    Console.WriteLine("\nResultado:");
                    operadores.Multiplicar(num1, num2);
                    break;

                case Operacao.Dividir:
                    Console.WriteLine("\nResultado:");
                    operadores.Dividir(num1, num2);
                    break;

                default:
                    Console.WriteLine("X - Operação inválida! - X");
                    break;
            }
            Console.WriteLine("\nDeseja calcular outro valor? (S/N)");
            continuar = Console.ReadLine()?.ToUpper();
        }
        while (continuar == "S");
    }
}