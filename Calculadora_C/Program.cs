internal class Program
{
    private static void Main(string[] args)
    {
        bool controlator = true;
       

        Console.WriteLine("Calculadora em C# \r");
        Console.WriteLine("------------------------\n");

        while (controlator)
        {

            Console.Write("Primeiro número: ");


            if (!float.TryParse(Console.ReadLine(), out float num1))
            {
                if (End()) break;
            }


            Console.Write("Segundo número: ");

            if (!float.TryParse(Console.ReadLine(), out float num2))
            {
                if (End()) break;
            }


            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("\ta - Somar");
            Console.WriteLine("\ts - Subtrair");
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");
            Console.Write("Qual você deseja ? ");


            var result = Console.ReadLine();

            switch (result)
            {
                case "a":
                    Console.WriteLine($"{num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"{num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"{num1} * {num2} = " + num1 * num2);
                    break;
                case "d":
                    while (num2 == 0)
                    {
                        Console.WriteLine("O divisor não pode ser zero. Digite outro: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"{num1} / {num2} = " + num1 / num2);
                    break;
                default:
                    if (End()) controlator = false;
                    break;
            }

            if (controlator)
            {
                // Aguardando a resposta do usuário:
                Console.WriteLine("Deseja continuar ? (s/n) \n");
                if (Console.ReadLine() == "n")
                {
                    break;
                }
                Console.Clear();

            }
        }
    }

    private static bool End()
    {
        string mensagemErro = "Programa finalizado pois você inseriu um valor inválido";
        Console.WriteLine(mensagemErro);
        return true;
    }
  
}