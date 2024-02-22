using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numerobyte = 10;
            sbyte numerosbyte = -10;
            int numeroint = 20;
            uint numerounint = 30u;
            long numerolong = 40L;
            ulong numeroulong = 50UL;
            short numeroshort = 60;
            ushort numeroushort = 70;

            Console.WriteLine(numerobyte);
            Console.WriteLine(numerosbyte);
            Console.WriteLine(numeroint);
            Console.WriteLine(numerounint);
            Console.WriteLine(numerolong);
            Console.WriteLine(numeroulong);
            Console.WriteLine(numeroshort);
            Console.WriteLine(numeroushort);

            char heart = '\u2661';
            char club = '\u2667';
            char diamond = '\u2662';
            char spades = '\u2664';
            char star = '\u2606';
            char skull = '\u2620';

            Console.WriteLine(heart);
            Console.WriteLine(club);
            Console.WriteLine(diamond);
            Console.WriteLine(spades);
            Console.WriteLine(star);
            Console.WriteLine(skull);


        }
    }
}
