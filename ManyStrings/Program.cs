using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sign = "The sign says \"Hello World!\"";
            string instruction = "Follow the arrows!\u27A5\u27A5\u27A5";
            string warning = "\u274CDon't touch the grass!\u274C";
            string message = "Kindly check the attached \"Love Letter\"\u2765";
            string path = "Check: C:\\ProgramData\\Microsoft\\Windows";

            Console.WriteLine(sign);
            Console.WriteLine(instruction);
            Console.WriteLine(warning);
            Console.WriteLine(message);
            Console.WriteLine(path);

        }
    }
}
