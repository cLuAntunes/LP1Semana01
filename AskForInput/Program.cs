using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, insira um número inteiro: ");
            string inp = Console.ReadLine();

            int inteiro = int.Parse(inp);

            Console.WriteLine("Por favor, insira um número real: ");
            string rl = Console.ReadLine();

            float real = float.Parse(rl);

            float sum = inteiro + real;

            string aws = $"The result is {sum}"; 

            Console.WriteLine(aws);


        }
    }
}
