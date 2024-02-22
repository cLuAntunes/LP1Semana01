using System;
using System.Security.Cryptography.X509Certificates;

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


            float x = 6.7f;
            int y = 20;
            string s = "verycool"+ 222 + ".com";
            string a = "How " + "are " + "you" + "?";
            string b = "Please check: " + s + " for more information.";
            string c = $"The result is {x + y}";
            string d = $"The value of y is {y}";
            string e = $"{s} is a very dangerous site.";

            Console.WriteLine(s);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

        }
    }
}
