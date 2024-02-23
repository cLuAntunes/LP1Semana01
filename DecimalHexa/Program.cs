using System;

namespace DecimalHexa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira quatro números inteiros: ");
            
            string numero1 = Console.ReadLine();
            string numero2 = Console.ReadLine();
            string numero3 = Console.ReadLine();
            string numero4 = Console.ReadLine();

            
            int num1 = int.Parse(numero1);
            int num2 = int.Parse(numero2);
            int num3 = int.Parse(numero3);
            int num4 = int.Parse(numero4);

            Console.WriteLine($"{num1,6}  {num1,6:X}");
            Console.WriteLine($"{num2,6}  {num2,6:X}");
            Console.WriteLine($"{num3,6}  {num3,6:X}");
            Console.WriteLine($"{num4,6}  {num4,6:X}");

        }
    }
}
